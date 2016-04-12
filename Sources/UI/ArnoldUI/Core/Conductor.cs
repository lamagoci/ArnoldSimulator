﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using GoodAI.Arnold.Network;
using GoodAI.Arnold.Simulation;
using GoodAI.Net.ConverseSharp;

namespace ArnoldUI.Core
{
    public class Conductor
    {
        public const int TcpTimeoutMs = 5000;

        private ICoreProxy m_proxy;
        private EndPoint m_endPoint;
        private ICoreLink m_coreLink;
        private ISimulation m_simulation;

        public void Setup()
        {
            CleanOldProxy();
            m_proxy = new LocalCoreProxy();

            StartProxy();

            // TODO(HonzaS): How to better handle resolution here?
            m_coreLink = new CoreLink(
                new ConverseProtoBufClient(new TcpConnector(m_endPoint.Hostname, m_endPoint.Port, TcpTimeoutMs)));

            // TODO(HonzaS): Simulation should only be present after there has been a blueprint upload.
            m_simulation = new SimulationProxy(m_coreLink);
        }

        private void StartProxy()
        {
            m_endPoint = m_proxy.Start();
        }

        private void CleanOldProxy()
        {
            m_proxy?.Dispose();
        }
    }
}

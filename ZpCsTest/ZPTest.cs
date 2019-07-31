﻿using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using ZennoLab.CommandCenter;
using ZennoLab.InterfacesLibrary.ProjectModel;

namespace ZPTest
{
    public class Main : IZennoCustomCode, IZennoCustomEndCode
    {
        public int ExecuteCode(Instance instance, IZennoPosterProjectModel project)
        {
            project.SendInfoToLog("Test");

            return 0;
        }

        public void GoodEnd(Instance instance, IZennoPosterProjectModel project) { }

        public void BadEnd(Instance instance, IZennoPosterProjectModel project) { }
    }
}

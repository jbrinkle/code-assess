﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevatorsim.Simulator
{
    public interface IElevatorLandscape
    {
        uint FindNearestElevatorToFloor(int floor);
    }
}
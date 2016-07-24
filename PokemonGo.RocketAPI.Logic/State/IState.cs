﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGo.RocketAPI.Logic.State
{
    public interface IState
    {
        IState Execute(Context ctx, StateMachine machine);
    }
}
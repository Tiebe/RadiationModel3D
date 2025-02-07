﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace RadiationModel.substances
{
    public class AlphaParticle : RadioactiveSubstance
    {
        public AlphaParticle() { Debug.LogWarning("Alpha particle created with default constructor. Are you sure?"); }

        public AlphaParticle(double energy)
        {
            this.energy = energy;
        }
        public override string name => "Helium-4 nucleus";
        public override double halfLife => double.PositiveInfinity;
        public override double atomicWeight => 4.002602d;
        public double energy { get; }
        
        public double speed => Math.Sqrt(2 * energy * 1.602176634e-19 / (atomicWeight * 1.66053906892e-27));
        
        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new();
    }
}
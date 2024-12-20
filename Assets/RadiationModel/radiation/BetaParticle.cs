﻿using System.Collections.Generic;
using UnityEngine;

namespace RadiationModel
{
    public class BetaParticle : RadioactiveSubstance
    {
        public BetaParticle() { Debug.LogWarning("Beta particle created with default constructor. Are you sure?"); }
        public BetaParticle(int charge, Dictionary<double, double> spectrum) => (this.charge, this.spectrum) = (charge, spectrum);
        public override string name => "Electron";
        public override double halfLife => double.PositiveInfinity;
        public override double atomicWeight => 0;
        public double energy { get; set; }
        public Dictionary<double, double> spectrum { get; set; }
        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new();
    }
}
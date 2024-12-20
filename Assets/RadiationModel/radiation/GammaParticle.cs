﻿using System.Collections.Generic;
using UnityEngine;

namespace RadiationModel
{
    public class GammaParticle : RadioactiveSubstance
    {
        public GammaParticle() { Debug.LogWarning("Gamma particle created with default constructor. Are you sure?"); }
        public GammaParticle(double energy, double wavelength) => (this.energy, this.wavelength) = (energy, wavelength);
        public override string name { get; } = "Gamma particle";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 0;
        public double wavelength { get; } = 0;
        public double energy { get; } = 0;
        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new();
    }
}
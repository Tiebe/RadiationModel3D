using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum28 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum28";
        public override double halfLife { get; } = 134.7d;
        public override double atomicWeight { get; } = 27.98191d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silicon28() }, { 1.0d, new BetaParticle(-1, 2321038.55) }, { 1.0d, new GammaParticle(1778987.0, 0.0007) }, { 9.2686825e-09d, new GammaParticle(118.0, 10.50714) }, { 2.7914816920982667e-07d, new GammaParticle(1740.0, 0.71255) }, { 1.406069328309897e-07d, new GammaParticle(1740.0, 0.71255) }, { 1.2172897959183676e-08d, new GammaParticle(1836.0, 0.6753) }, { 1.2172897959183676e-08d, new GammaParticle(1836.0, 0.6753) } } },

        };
    }
}
    
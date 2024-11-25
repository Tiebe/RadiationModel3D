using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium87 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium87";
        public override double halfLife { get; } = 1.5683792209372224e+18d;
        public override double atomicWeight { get; } = 86.90918d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Strontium87() }, { 1.0d, new BetaParticle(-1, 141137.0) } } },

        };
    }
}
    
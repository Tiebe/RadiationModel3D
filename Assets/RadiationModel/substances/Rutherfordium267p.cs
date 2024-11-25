using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium267p : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium267p";
        public override double halfLife { get; } = 4680.0d;
        public override double atomicWeight { get; } = 267.12187d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.33299999999999996d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new AlphaParticle(245095066215.22) } } },

        };
    }
}
    
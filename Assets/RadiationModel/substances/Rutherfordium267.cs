using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium267 : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium267";
        public override double halfLife { get; } = 4680.0d;
        public override double atomicWeight { get; } = 267.12178d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.33299999999999996d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new AlphaParticle(245094986215.22) } } },

        };
    }
}
    
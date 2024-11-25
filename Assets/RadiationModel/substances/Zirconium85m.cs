using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium85m : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium85m";
        public override double halfLife { get; } = 10.9d;
        public override double atomicWeight { get; } = 84.92176d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium85() } } },
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Strontium85() }, { 1.0d, new BetaParticle(1, 4110150.0) } } },

        };
    }
}
    
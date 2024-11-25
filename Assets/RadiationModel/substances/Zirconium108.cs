using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium108 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium108";
        public override double halfLife { get; } = 0.0774d;
        public override double atomicWeight { get; } = 107.9453d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium108() }, { 1.0d, new BetaParticle(-1, 4297500.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    
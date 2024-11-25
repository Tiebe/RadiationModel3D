using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copernicium285 : RadioactiveSubstance
    {
        public override string name { get; } = "Copernicium285";
        public override double halfLife { get; } = 33.0d;
        public override double atomicWeight { get; } = 285.17723d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Darmstadtium281() }, { 1.0d, new AlphaParticle(10417002.09) } } },
            { 0.06d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    
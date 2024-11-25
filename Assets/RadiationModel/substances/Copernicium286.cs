using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copernicium286 : RadioactiveSubstance
    {
        public override string name { get; } = "Copernicium286";
        public override double halfLife { get; } = 660.0d;
        public override double atomicWeight { get; } = 286.17869d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Darmstadtium282() }, { 1.0d, new AlphaParticle(10257002.09) } } },
            { 0.5d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    
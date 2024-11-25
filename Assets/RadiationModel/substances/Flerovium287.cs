using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Flerovium287 : RadioactiveSubstance
    {
        public override string name { get; } = "Flerovium287";
        public override double halfLife { get; } = 0.4d;
        public override double atomicWeight { get; } = 287.18672d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copernicium283() }, { 1.0d, new AlphaParticle(11187002.09) } } },
            { 0.05d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    
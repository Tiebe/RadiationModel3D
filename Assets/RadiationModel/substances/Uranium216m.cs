using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium216m : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium216m";
        public override double halfLife { get; } = 0.0007d;
        public override double atomicWeight { get; } = 216.02718d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thorium212() }, { 1.0d, new AlphaParticle(11806002.09) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    
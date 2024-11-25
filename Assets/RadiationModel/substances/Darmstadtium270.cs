using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Darmstadtium270 : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium270";
        public override double halfLife { get; } = 0.0002d;
        public override double atomicWeight { get; } = 270.14458d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hassium266() }, { 1.0d, new AlphaParticle(12137002.09) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    
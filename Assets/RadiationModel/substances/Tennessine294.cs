using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tennessine294 : RadioactiveSubstance
    {
        public override string name { get; } = "Tennessine294";
        public override double halfLife { get; } = 0.051d;
        public override double atomicWeight { get; } = 294.21084d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Moscovium290() }, { 1.0d, new AlphaParticle(12207002.09) } } },

        };
    }
}
    
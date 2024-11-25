using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon195m : RadioactiveSubstance
    {
        public override string name { get; } = "Radon195m";
        public override double halfLife { get; } = 0.005d;
        public override double atomicWeight { get; } = 195.00551d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium191() }, { 1.0d, new AlphaParticle(8797002.09) } } },

        };
    }
}
    
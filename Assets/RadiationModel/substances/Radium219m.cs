using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium219m : RadioactiveSubstance
    {
        public override string name { get; } = "Radium219m";
        public override double halfLife { get; } = 0.01d;
        public override double atomicWeight { get; } = 219.0101d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radon215() }, { 1.0d, new AlphaParticle(9177002.09) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    
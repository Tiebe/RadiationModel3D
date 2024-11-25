using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium171m : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium171m";
        public override double halfLife { get; } = 29.5d;
        public override double atomicWeight { get; } = 170.94052d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium171() }, { 1.84e-06d, new GammaParticle(21930.0, 0.05654) }, { 0.18303999999999998d, new GammaParticle(9114.0, 0.13604) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    
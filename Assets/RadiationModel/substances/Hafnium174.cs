using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium174 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium174";
        public override double halfLife { get; } = 6.3113851949184e+22d;
        public override double atomicWeight { get; } = 173.94005d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ytterbium170() }, { 1.0d, new AlphaParticle(3516331.0900000003) } } },

        };
    }
}
    
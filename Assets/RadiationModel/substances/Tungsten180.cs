using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten180 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten180";
        public override double halfLife { get; } = 5.68024667542656e+25d;
        public override double atomicWeight { get; } = 179.94671d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium176() }, { 1.0d, new AlphaParticle(3537202.0900000003) } } },

        };
    }
}
    
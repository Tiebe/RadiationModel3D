using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten158 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten158";
        public override double halfLife { get; } = 0.00125d;
        public override double atomicWeight { get; } = 157.97457d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium154() }, { 1.0d, new AlphaParticle(7637002.09) } } },

        };
    }
}
    
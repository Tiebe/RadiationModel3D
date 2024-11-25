using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum182m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum182m";
        public override double halfLife { get; } = 0.283d;
        public override double atomicWeight { get; } = 181.95017d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum182() }, { 2.32e-05d, new GammaParticle(16273.0, 0.07619) }, { 0.202912d, new GammaParticle(9424.0, 0.13156) } } },

        };
    }
}
    
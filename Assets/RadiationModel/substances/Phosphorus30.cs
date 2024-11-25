using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus30 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus30";
        public override double halfLife { get; } = 150.0d;
        public override double atomicWeight { get; } = 29.97831d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Aluminum30() }, { 1.0d, new BetaParticle(1, -2168380.0) }, { 8.1e-06d, new GammaParticle(1263130.0, 0.00098) }, { 1e-06d, new GammaParticle(1534120.0, 0.00081) }, { 3.4e-05d, new GammaParticle(1552360.0, 0.0008) }, { 0.0005899999999999999d, new GammaParticle(2235230.0, 0.00055) }, { 6.6e-06d, new GammaParticle(3498330.0, 0.00035) }, { 8.000000000000001e-07d, new GammaParticle(3769220.0, 0.00033) }, { 1.9971199999999998d, new GammaParticle(511000.0, 0.00243) }, { 1.4265171222302389e-06d, new GammaParticle(118.0, 10.50714) }, { 2.1430905984907003e-05d, new GammaParticle(1740.0, 0.71255) }, { 4.254696443300974e-05d, new GammaParticle(1740.0, 0.71255) }, { 1.8553582421195856e-06d, new GammaParticle(1836.0, 0.6753) }, { 1.8553582421195856e-06d, new GammaParticle(1836.0, 0.6753) } } },

        };
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten166 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten166";
        public override double halfLife { get; } = 19.2d;
        public override double atomicWeight { get; } = 165.95503d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99965d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium166() }, { 1.0d, new BetaParticle(1, 5986000.0) }, { 0.0046d, new GammaParticle(45800.0, 0.02707) }, { 0.0062d, new GammaParticle(97700.0, 0.01269) }, { 0.33d, new GammaParticle(125800.0, 0.00986) }, { 0.019d, new GammaParticle(172500.0, 0.00719) }, { 0.026000000000000002d, new GammaParticle(224600.0, 0.00552) }, { 0.0076d, new GammaParticle(270100.0, 0.00459) }, { 0.018000000000000002d, new GammaParticle(395900.0, 0.00313) }, { 0.8d, new GammaParticle(511000.0, 0.00243) }, { 0.3d, new GammaParticle(9424.0, 0.13156) }, { 0.27d, new GammaParticle(56280.0, 0.02203) }, { 0.48d, new GammaParticle(57535.0, 0.02155) }, { 0.16d, new GammaParticle(65315.0, 0.01898) }, { 0.2d, new GammaParticle(66067.0, 0.01877) }, { 0.043d, new GammaParticle(66981.0, 0.01851) } } },
            { 0.00035000000000000005d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium162() }, { 1.0d, new AlphaParticle(5878002.09) } } },

        };
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten175 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten175";
        public override double halfLife { get; } = 2112.0d;
        public override double atomicWeight { get; } = 174.94672d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium175() }, { 1.0d, new BetaParticle(1, 2424400.00001) }, { 0.017d, new GammaParticle(121200.0, 0.01023) }, { 0.034d, new GammaParticle(149200.0, 0.00831) }, { 0.085d, new GammaParticle(166700.0, 0.00744) }, { 0.12d, new GammaParticle(270300.0, 0.00459) }, { 0.0258573407616d, new GammaParticle(9424.0, 0.13156) }, { 0.02305775752063748d, new GammaParticle(56280.0, 0.02203) }, { 0.04019832203737357d, new GammaParticle(57535.0, 0.02155) }, { 0.013298719088180278d, new GammaParticle(65315.0, 0.01898) }, { 0.016889373241988952d, new GammaParticle(66067.0, 0.01877) }, { 0.003590654153808675d, new GammaParticle(66981.0, 0.01851) } } },

        };
    }
}
    
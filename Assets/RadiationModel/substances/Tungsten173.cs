using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten173 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten173";
        public override double halfLife { get; } = 456.0d;
        public override double atomicWeight { get; } = 172.94769d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium173() }, { 1.0d, new BetaParticle(1, 3342500.0) }, { 0.376d, new GammaParticle(511000.0, 0.00243) }, { 0.1662495824d, new GammaParticle(9424.0, 0.13156) }, { 0.16901711162355668d, new GammaParticle(56280.0, 0.02203) }, { 0.29466023644274175d, new GammaParticle(57535.0, 0.02155) }, { 0.09748177317614305d, new GammaParticle(65315.0, 0.01898) }, { 0.12380185193370168d, new GammaParticle(66067.0, 0.01877) }, { 0.026320078757558624d, new GammaParticle(66981.0, 0.01851) } } },

        };
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium182 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium182";
        public override double halfLife { get; } = 280856641173868.8d;
        public override double atomicWeight { get; } = 181.95056d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum182() }, { 1.0d, new BetaParticle(-1, 190349.99999) }, { 0.0011d, new GammaParticle(97850.0, 0.01267) }, { 0.03d, new GammaParticle(114320.0, 0.01085) }, { 0.07d, new GammaParticle(156090.0, 0.00794) }, { 0.002d, new GammaParticle(172550.0, 0.00719) }, { 0.79d, new GammaParticle(270408.0, 0.00459) }, { 0.052546852032000005d, new GammaParticle(9424.0, 0.13156) }, { 0.04539113251523059d, new GammaParticle(56280.0, 0.02203) }, { 0.07913377356211748d, new GammaParticle(57535.0, 0.02155) }, { 0.026179645608387352d, new GammaParticle(65315.0, 0.01898) }, { 0.03324814992265193d, new GammaParticle(66067.0, 0.01877) }, { 0.007068504314264585d, new GammaParticle(66981.0, 0.01851) } } },

        };
    }
}
    
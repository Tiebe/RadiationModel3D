using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium75 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium75";
        public override double halfLife { get; } = 0.088d;
        public override double atomicWeight { get; } = 74.94995d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Krypton75() }, { 1.0d, new BetaParticle(1, 8852000.0) }, { 0.045d, new GammaParticle(144000.0, 0.00861) }, { 1.994d, new GammaParticle(511000.0, 0.00243) }, { 7.63126017e-05d, new GammaParticle(1767.0, 0.70166) }, { 0.0005098848972407453d, new GammaParticle(13336.0, 0.09297) }, { 0.0009814916212526378d, new GammaParticle(13396.0, 0.09255) }, { 0.0002389409690919506d, new GammaParticle(15021.0, 0.08254) }, { 0.0002666581215066169d, new GammaParticle(15070.0, 0.08227) }, { 2.771715241466627e-05d, new GammaParticle(15187.0, 0.08164) } } },
            { 0.052000000000000005d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Krypton74() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium85m : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium85m";
        public override double halfLife { get; } = 4057.8d;
        public override double atomicWeight { get; } = 84.91319d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.866d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Strontium85() }, { 4.2e-08d, new GammaParticle(6920.0, 0.17917) }, { 0.8390000000000001d, new GammaParticle(231860.0, 0.00535) }, { 0.0027500000000000003d, new GammaParticle(238780.0, 0.00519) }, { 0.01894497553828d, new GammaParticle(1890.0, 0.656) }, { 0.004235598928209277d, new GammaParticle(14098.0, 0.08794) }, { 0.008137557979268543d, new GammaParticle(14165.0, 0.08753) }, { 0.0020092692854178583d, new GammaParticle(15898.0, 0.07799) }, { 0.00227047429252218d, new GammaParticle(15955.0, 0.07771) }, { 0.0002612050071043216d, new GammaParticle(16085.0, 0.07708) } } },
            { 0.134d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rubidium85() }, { 0.0015d, new GammaParticle(129820.0, 0.00955) }, { 0.128d, new GammaParticle(151194.0, 0.0082) }, { 4e-06d, new GammaParticle(281010.0, 0.00441) }, { 0.000107d, new GammaParticle(450790.0, 0.00275) }, { 8.7e-06d, new GammaParticle(580640.0, 0.00214) }, { 0.000146d, new GammaParticle(731797.0, 0.00169) }, { 2.9999999999999997e-06d, new GammaParticle(768500.0, 0.00161) }, { 1e-06d, new GammaParticle(919800.0, 0.00135) }, { 0.00362285352547425d, new GammaParticle(1767.0, 0.70166) }, { 0.024034544092652266d, new GammaParticle(13336.0, 0.09297) }, { 0.04626476244976375d, new GammaParticle(13396.0, 0.09255) }, { 0.011263007177225792d, new GammaParticle(15021.0, 0.08254) }, { 0.012569516009783985d, new GammaParticle(15070.0, 0.08227) }, { 0.001306508832558192d, new GammaParticle(15187.0, 0.08164) } } },

        };
    }
}
    
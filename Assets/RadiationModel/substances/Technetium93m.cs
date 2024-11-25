using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium93m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium93m";
        public override double halfLife { get; } = 2610.0d;
        public override double atomicWeight { get; } = 92.91067d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.774d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium93() }, { 0.583d, new GammaParticle(391830.0, 0.00316) }, { 0.006983984370000001d, new GammaParticle(2586.0, 0.47944) }, { 0.031381058331289124d, new GammaParticle(18250.0, 0.06794) }, { 0.059671151038769965d, new GammaParticle(18367.0, 0.0675) }, { 0.015859439231382486d, new GammaParticle(20695.0, 0.05991) }, { 0.01836523062994092d, new GammaParticle(20820.0, 0.05955) }, { 0.002505791398558433d, new GammaParticle(21003.0, 0.05903) } } },
            { 0.226d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium93() }, { 1.0d, new BetaParticle(1, 1999250.0) }, { 0.0013992d, new GammaParticle(288300.0, 0.0043) }, { 0.0033231d, new GammaParticle(309200.0, 0.00401) }, { 0.02915d, new GammaParticle(943700.0, 0.00131) }, { 0.012242999999999999d, new GammaParticle(1046800.0, 0.00118) }, { 0.0056551d, new GammaParticle(1343800.0, 0.00092) }, { 0.019239d, new GammaParticle(1492200.0, 0.00083) }, { 0.006412999999999999d, new GammaParticle(1694000.0, 0.00073) }, { 0.009328d, new GammaParticle(2011900.0, 0.00062) }, { 0.0066462d, new GammaParticle(2029400.0, 0.00061) }, { 0.005829999999999999d, new GammaParticle(2182000.0, 0.00057) }, { 0.143418d, new GammaParticle(2644580.0, 0.00047) }, { 0.0074041d, new GammaParticle(2698300.0, 0.00046) }, { 0.009269699999999999d, new GammaParticle(2739500.0, 0.00045) }, { 0.003498d, new GammaParticle(2861500.0, 0.00043) }, { 0.021570999999999996d, new GammaParticle(3129000.0, 0.0004) }, { 0.010494000000000002d, new GammaParticle(3220300.0, 0.00039) }, { 0.004489099999999999d, new GammaParticle(3298100.0, 0.00038) }, { 0.062116d, new GammaParticle(511000.0, 0.00243) }, { 0.008100000000000001d, new GammaParticle(2440.0, 0.50813) }, { 0.0406d, new GammaParticle(17374.0, 0.07136) }, { 0.077d, new GammaParticle(17479.0, 0.07093) }, { 0.0203d, new GammaParticle(19681.0, 0.063) }, { 0.0235d, new GammaParticle(19794.0, 0.06264) }, { 0.00313d, new GammaParticle(19963.0, 0.06211) } } },

        };
    }
}
    
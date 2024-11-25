using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony122 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony122";
        public override double halfLife { get; } = 235336.32d;
        public override double atomicWeight { get; } = 121.90517d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9759d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium122() }, { 1.0d, new BetaParticle(-1, 989550.0) }, { 0.7068000000000001d, new GammaParticle(564240.0, 0.0022) }, { 0.00011308800000000001d, new GammaParticle(615000.0, 0.00202) }, { 0.038520599999999995d, new GammaParticle(692650.0, 0.00179) }, { 0.000162564d, new GammaParticle(793300.0, 0.00156) }, { 4.2408000000000005e-05d, new GammaParticle(1188000.0, 0.00104) }, { 0.0081282d, new GammaParticle(1256930.0, 0.00099) }, { 9.188399999999999e-05d, new GammaParticle(1752400.0, 0.00071) }, { 0.00033194504093905867d, new GammaParticle(4135.0, 0.29984) }, { 0.0009112879152855171d, new GammaParticle(27202.0, 0.04558) }, { 0.0016969979800475178d, new GammaParticle(27473.0, 0.04513) }, { 0.00048565126038000464d, new GammaParticle(31093.0, 0.03988) }, { 0.0005910375838824657d, new GammaParticle(31359.0, 0.03954) }, { 0.00010538632350246101d, new GammaParticle(31698.0, 0.03911) } } },
            { 0.0241d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium122() }, { 1.0d, new BetaParticle(1, -2382100.0) }, { 0.007562759999999999d, new GammaParticle(1140670.0, 0.00109) }, { 0.00012200000000000001d, new GammaParticle(511000.0, 0.00243) }, { 0.0016454358572375585d, new GammaParticle(3753.0, 0.33036) }, { 0.0050906132999107975d, new GammaParticle(25044.0, 0.04951) }, { 0.009527631105953204d, new GammaParticle(25271.0, 0.04906) }, { 0.00269405573595121d, new GammaParticle(28579.0, 0.04338) }, { 0.003224784715933599d, new GammaParticle(28810.0, 0.04304) }, { 0.0005307289799823884d, new GammaParticle(29107.0, 0.0426) } } },

        };
    }
}
    
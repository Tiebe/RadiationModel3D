using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium86m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium86m";
        public override double halfLife { get; } = 2844.0d;
        public override double atomicWeight { get; } = 85.91512d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9931d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Yttrium86() }, { 4.3999999999999997e-07d, new GammaParticle(10200.0, 0.12155) }, { 0.938d, new GammaParticle(208100.0, 0.00596) }, { 0.02520164367192d, new GammaParticle(2027.0, 0.61166) }, { 0.00984886708992403d, new GammaParticle(14883.0, 0.08331) }, { 0.018885651179144834d, new GammaParticle(14958.0, 0.08289) }, { 0.004741953014877973d, new GammaParticle(16803.0, 0.07379) }, { 0.005396342530931133d, new GammaParticle(16880.0, 0.07345) }, { 0.0006543895160531603d, new GammaParticle(17011.0, 0.07288) } } },
            { 0.0069d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rubidium86() }, { 1.0d, new BetaParticle(1, 1841000.0) }, { 0.0033d, new GammaParticle(98600.0, 0.01257) }, { 0.0069d, new GammaParticle(627200.0, 0.00198) }, { 0.0069d, new GammaParticle(1076600.0, 0.00115) }, { 0.0069d, new GammaParticle(1153100.0, 0.00108) }, { 0.0088d, new GammaParticle(511000.0, 0.00243) }, { 0.00017042014900800002d, new GammaParticle(1890.0, 0.656) }, { 0.001051248770428979d, new GammaParticle(14098.0, 0.08794) }, { 0.0020196902409778655d, new GammaParticle(14165.0, 0.08753) }, { 0.0004986878837107574d, new GammaParticle(15898.0, 0.07799) }, { 0.0005635173085931558d, new GammaParticle(15955.0, 0.07771) }, { 6.482942488239847e-05d, new GammaParticle(16085.0, 0.07708) } } },

        };
    }
}
    
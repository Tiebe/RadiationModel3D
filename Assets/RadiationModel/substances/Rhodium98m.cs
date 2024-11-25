using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium98m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium98m";
        public override double halfLife { get; } = 216.0d;
        public override double atomicWeight { get; } = 97.91077d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.89d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium98() } } },
            { 0.11d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium98() }, { 1.0d, new BetaParticle(1, 1656500.0) }, { 0.0028000000000000004d, new GammaParticle(383000.0, 0.00324) }, { 0.011000000000000001d, new GammaParticle(599000.0, 0.00207) }, { 0.011000000000000001d, new GammaParticle(615700.0, 0.00201) }, { 0.1d, new GammaParticle(652600.0, 0.0019) }, { 0.09d, new GammaParticle(745400.0, 0.00166) }, { 0.008d, new GammaParticle(761500.0, 0.00163) }, { 0.0023d, new GammaParticle(824400.0, 0.0015) }, { 0.0039000000000000003d, new GammaParticle(1121100.0, 0.00111) }, { 0.006999999999999999d, new GammaParticle(1144200.0, 0.00108) }, { 0.0037d, new GammaParticle(1164100.0, 0.00107) }, { 0.0018d, new GammaParticle(1360900.0, 0.00091) }, { 0.006d, new GammaParticle(1413400.0, 0.00088) }, { 0.004d, new GammaParticle(1428100.0, 0.00087) }, { 0.0051d, new GammaParticle(1624700.0, 0.00076) }, { 0.0014000000000000002d, new GammaParticle(1816400.0, 0.00068) }, { 0.0014000000000000002d, new GammaParticle(2417000.0, 0.00051) }, { 0.18658000000000002d, new GammaParticle(511000.0, 0.00243) }, { 0.001342855664823d, new GammaParticle(2737.0, 0.45299) }, { 0.006020335713020727d, new GammaParticle(19150.0, 0.06474) }, { 0.011423786931728136d, new GammaParticle(19279.0, 0.06431) }, { 0.0030699854396309314d, new GammaParticle(21736.0, 0.05704) }, { 0.003567323080851142d, new GammaParticle(21875.0, 0.05668) }, { 0.0004973376412202108d, new GammaParticle(22072.0, 0.05617) } } },

        };
    }
}
    
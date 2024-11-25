using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium155m : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium155m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 154.92601d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium155() }, { 0.00047d, new GammaParticle(9100.0, 0.13625) }, { 7.5e-05d, new GammaParticle(22150.0, 0.05597) }, { 0.055d, new GammaParticle(39390.0, 0.03148) }, { 0.44d, new GammaParticle(45380.0, 0.02732) }, { 0.134d, new GammaParticle(47370.0, 0.02617) }, { 0.043d, new GammaParticle(79720.0, 0.01555) }, { 0.046d, new GammaParticle(86750.0, 0.01429) }, { 0.091d, new GammaParticle(102160.0, 0.01214) }, { 0.106d, new GammaParticle(138460.0, 0.00895) }, { 0.075d, new GammaParticle(147630.0, 0.0084) }, { 0.040999999999999995d, new GammaParticle(185890.0, 0.00667) }, { 0.379691740372d, new GammaParticle(7384.0, 0.16791) }, { 0.1387514326505255d, new GammaParticle(45207.0, 0.02743) }, { 0.2479475208193808d, new GammaParticle(45998.0, 0.02695) }, { 0.07961087978578865d, new GammaParticle(52220.0, 0.02374) }, { 0.1003097085300937d, new GammaParticle(52791.0, 0.02349) }, { 0.02069882874430505d, new GammaParticle(53478.0, 0.02318) } } },

        };
    }
}
    
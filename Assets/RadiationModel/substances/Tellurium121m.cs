using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium121m : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium121m";
        public override double halfLife { get; } = 14186880.0d;
        public override double atomicWeight { get; } = 120.90526d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.8859999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium121() }, { 0.0005099999999999999d, new GammaParticle(81788.0, 0.01516) }, { 0.815d, new GammaParticle(212189.0, 0.00584) }, { 0.06886249912828d, new GammaParticle(4135.0, 0.29984) }, { 0.1012903269305498d, new GammaParticle(27202.0, 0.04558) }, { 0.18862258273845403d, new GammaParticle(27473.0, 0.04513) }, { 0.0539804973960528d, new GammaParticle(31093.0, 0.03988) }, { 0.06569426533099626d, new GammaParticle(31359.0, 0.03954) }, { 0.011713767934943458d, new GammaParticle(31698.0, 0.03911) } } },
            { 0.114d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin121() }, { 1.0d, new BetaParticle(1, 473800.0) }, { 0.009399999999999999d, new GammaParticle(37138.0, 0.03338) }, { 9e-06d, new GammaParticle(103850.0, 0.01194) }, { 0.0007000000000000001d, new GammaParticle(909847.0, 0.00136) }, { 8.2e-05d, new GammaParticle(946989.0, 0.00131) }, { 0.0008d, new GammaParticle(998291.0, 0.00124) }, { 8.000000000000001e-07d, new GammaParticle(1024000.0, 0.00121) }, { 5.999999999999999e-06d, new GammaParticle(1035400.0, 0.0012) }, { 0.025d, new GammaParticle(1102149.0, 0.00112) }, { 4e-06d, new GammaParticle(1107600.0, 0.00112) }, { 1.08e-05d, new GammaParticle(1144650.0, 0.00108) }, { 2.2000000000000003e-05d, new GammaParticle(511000.0, 0.00243) }, { 0.015562161627377d, new GammaParticle(3941.0, 0.3146) }, { 0.04546765449467794d, new GammaParticle(26111.0, 0.04748) }, { 0.08489106515063095d, new GammaParticle(26359.0, 0.04704) }, { 0.024149303821616463d, new GammaParticle(29821.0, 0.04158) }, { 0.02914820971269107d, new GammaParticle(30069.0, 0.04123) }, { 0.004998905891074608d, new GammaParticle(30387.0, 0.0408) } } },

        };
    }
}
    
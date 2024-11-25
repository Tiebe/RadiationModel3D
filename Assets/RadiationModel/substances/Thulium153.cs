using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium153 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium153";
        public override double halfLife { get; } = 1.48d;
        public override double atomicWeight { get; } = 152.94206d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.91d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Holmium149() }, { 1.0d, new AlphaParticle(6270002.09) } } },
            { 0.09d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Holmium153() }, { 1.0d, new BetaParticle(1, 5519500.0) }, { 0.0062d, new GammaParticle(205200.0, 0.00604) }, { 0.064d, new GammaParticle(299300.0, 0.00414) }, { 0.0042d, new GammaParticle(712600.0, 0.00174) }, { 0.019d, new GammaParticle(765800.0, 0.00162) }, { 0.005699999999999999d, new GammaParticle(811200.0, 0.00153) }, { 0.00192d, new GammaParticle(833400.0, 0.00149) }, { 0.0083d, new GammaParticle(965300.0, 0.00128) }, { 0.1412d, new GammaParticle(511000.0, 0.00243) }, { 0.004619779219728001d, new GammaParticle(7933.0, 0.15629) }, { 0.0057599753160883435d, new GammaParticle(48222.0, 0.02571) }, { 0.010223598360114206d, new GammaParticle(49128.0, 0.02524) }, { 0.0033222999569821015d, new GammaParticle(55779.0, 0.02223) }, { 0.004186097945797448d, new GammaParticle(56399.0, 0.02198) }, { 0.0008637979888153465d, new GammaParticle(57145.0, 0.0217) } } },

        };
    }
}
    
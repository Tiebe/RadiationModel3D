using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium157n : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium157n";
        public override double halfLife { get; } = 0.0216d;
        public override double atomicWeight { get; } = 156.92568d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium157() }, { 0.03565d, new GammaParticle(14200.0, 0.08731) }, { 0.23d, new GammaParticle(37300.0, 0.03324) }, { 0.016d, new GammaParticle(51500.0, 0.02407) }, { 0.069d, new GammaParticle(61000.0, 0.02033) }, { 0.20929999999999999d, new GammaParticle(87000.0, 0.01425) }, { 0.0667d, new GammaParticle(148000.0, 0.00838) }, { 0.42872440288999997d, new GammaParticle(7384.0, 0.16791) }, { 0.3225248789854334d, new GammaParticle(45207.0, 0.02743) }, { 0.5763489617323685d, new GammaParticle(45998.0, 0.02695) }, { 0.18505386847793479d, new GammaParticle(52220.0, 0.02374) }, { 0.23316787428219782d, new GammaParticle(52791.0, 0.02349) }, { 0.04811400580426304d, new GammaParticle(53478.0, 0.02318) } } },

        };
    }
}
    
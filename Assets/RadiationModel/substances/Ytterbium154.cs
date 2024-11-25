using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium154 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium154";
        public override double halfLife { get; } = 0.409d;
        public override double atomicWeight { get; } = 153.9464d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9259999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium150() }, { 1.0d, new AlphaParticle(6496002.09) } } },
            { 0.07400000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium154() }, { 1.0d, new BetaParticle(1, 6336500.0) }, { 0.048d, new GammaParticle(133200.0, 0.00931) }, { 0.001405769232d, new GammaParticle(8215.0, 0.15092) }, { 0.0016908350806363564d, new GammaParticle(49773.0, 0.02491) }, { 0.002985231427677183d, new GammaParticle(50742.0, 0.02443) }, { 0.0009760361045130641d, new GammaParticle(57612.0, 0.02152) }, { 0.001229805491686461d, new GammaParticle(58257.0, 0.02128) }, { 0.0002537693871733967d, new GammaParticle(59034.0, 0.021) } } },

        };
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium251 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium251";
        public override double halfLife { get; } = 3360.0d;
        public override double atomicWeight { get; } = 251.08076d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Californium251() }, { 1.0d, new BetaParticle(-1, 546500.0) }, { 0.0348d, new GammaParticle(130000.0, 0.00954) }, { 0.0231d, new GammaParticle(153000.0, 0.0081) }, { 0.0036d, new GammaParticle(164000.0, 0.00756) }, { 0.06d, new GammaParticle(178000.0, 0.00697) }, { 0.0018d, new GammaParticle(186800.0, 0.00664) }, { 0.35467550970600004d, new GammaParticle(19579.0, 0.06333) }, { 0.1536101660678058d, new GammaParticle(109867.0, 0.01128) }, { 0.23771303941164626d, new GammaParticle(115063.0, 0.01078) }, { 0.09061614050187901d, new GammaParticle(129671.0, 0.00956) }, { 0.12287548652054796d, new GammaParticle(131332.0, 0.00944) }, { 0.03225934601866892d, new GammaParticle(133529.0, 0.00929) } } },

        };
    }
}
    
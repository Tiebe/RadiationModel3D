using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium171 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium171";
        public override double halfLife { get; } = 8.3d;
        public override double atomicWeight { get; } = 170.96318d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.982d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tungsten171() }, { 1.0d, new BetaParticle(1, 6394500.0) }, { 0.7070000000000001d, new GammaParticle(189800.0, 0.00653) }, { 0.078d, new GammaParticle(326000.0, 0.0038) }, { 0.12d, new GammaParticle(705000.0, 0.00176) }, { 1.51d, new GammaParticle(511000.0, 0.00243) }, { 0.12095683751d, new GammaParticle(10063.0, 0.12321) }, { 0.0927809119582598d, new GammaParticle(59718.0, 0.02076) }, { 0.1605206089243249d, new GammaParticle(61141.0, 0.02028) }, { 0.053357955456080894d, new GammaParticle(69395.0, 0.01787) }, { 0.0681381091174153d, new GammaParticle(70206.0, 0.01766) }, { 0.014780153661334408d, new GammaParticle(71195.0, 0.01741) } } },
            { 0.018000000000000002d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tungsten167() }, { 1.0d, new AlphaParticle(6393002.09) }, { 9.400000000000001e-05d, new GammaParticle(79200.0, 0.01565) }, { 0.00016d, new GammaParticle(134200.0, 0.00924) }, { 0.00024607868799999996d, new GammaParticle(9740.0, 0.12729) }, { 0.0002192486666483816d, new GammaParticle(57983.0, 0.02138) }, { 0.00038083839959767514d, new GammaParticle(59320.0, 0.0209) }, { 0.00012623495585081885d, new GammaParticle(67335.0, 0.01841) }, { 0.0001608233337539432d, new GammaParticle(68117.0, 0.0182) }, { 3.458837790312436e-05d, new GammaParticle(69068.0, 0.01795) } } },

        };
    }
}
    
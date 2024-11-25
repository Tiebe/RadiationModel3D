using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium40 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium40";
        public override double halfLife { get; } = 0.1823d;
        public override double atomicWeight { get; } = 39.97797d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Potassium40() }, { 1.0d, new BetaParticle(1, 6506050.0) }, { 0.408114d, new GammaParticle(755600.0, 0.00164) }, { 0.11944800000000001d, new GammaParticle(1126000.0, 0.0011) }, { 0.24885000000000002d, new GammaParticle(1877800.0, 0.00066) }, { 0.253827d, new GammaParticle(2045800.0, 0.00061) }, { 0.0209034d, new GammaParticle(2844000.0, 0.00044) }, { 0.11944800000000001d, new GammaParticle(3167900.0, 0.00039) }, { 0.9954000000000001d, new GammaParticle(3735600.0, 0.00033) }, { 0.12940200000000002d, new GammaParticle(3920000.0, 0.00032) }, { 1.9906198000000002d, new GammaParticle(511000.0, 0.00243) }, { 1.9966518518136567e-06d, new GammaParticle(358.0, 3.46325) }, { 2.64166979099564e-05d, new GammaParticle(3688.0, 0.33618) }, { 5.219659733245683e-05d, new GammaParticle(3692.0, 0.33582) }, { 1.0188283063416756e-05d, new GammaParticle(4013.0, 0.30896) }, { 1.0188283063416756e-05d, new GammaParticle(4013.0, 0.30896) } } },
            { 0.0044d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Potassium39() }, { 1.0d, new ProtonParticle() } } },
            { 0.00017d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Argon36() }, { 1.0d, new AlphaParticle(8305144.09) } } },

        };
    }
}
    
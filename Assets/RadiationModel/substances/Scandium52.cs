using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium52 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium52";
        public override double halfLife { get; } = 8.2d;
        public override double atomicWeight { get; } = 51.9565d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Titanium52() }, { 1.0d, new BetaParticle(-1, 4476850.0) }, { 0.034159999999999996d, new GammaParticle(1025000.0, 0.00121) }, { 0.13663999999999998d, new GammaParticle(1032300.0, 0.0012) }, { 0.976d, new GammaParticle(1049700.0, 0.00118) }, { 0.053680000000000005d, new GammaParticle(1128100.0, 0.0011) }, { 0.06831999999999999d, new GammaParticle(1135000.0, 0.00109) }, { 0.11712d, new GammaParticle(1214500.0, 0.00102) }, { 0.39039999999999997d, new GammaParticle(1267900.0, 0.00098) }, { 0.10736000000000001d, new GammaParticle(1381900.0, 0.0009) }, { 0.02928d, new GammaParticle(1491000.0, 0.00083) }, { 0.018544d, new GammaParticle(1646000.0, 0.00075) }, { 0.040015999999999996d, new GammaParticle(1758200.0, 0.00071) }, { 0.016592d, new GammaParticle(1968400.0, 0.00063) }, { 0.016592d, new GammaParticle(1968400.0, 0.00063) }, { 0.032208d, new GammaParticle(2093400.0, 0.00059) }, { 0.015616000000000001d, new GammaParticle(2265200.0, 0.00055) }, { 0.07808d, new GammaParticle(2468800.0, 0.0005) }, { 0.038064d, new GammaParticle(2872000.0, 0.00043) }, { 0.025376d, new GammaParticle(2972200.0, 0.00042) }, { 0.020496d, new GammaParticle(3737200.0, 0.00033) }, { 0.008784d, new GammaParticle(3923000.0, 0.00032) } } },

        };
    }
}
    
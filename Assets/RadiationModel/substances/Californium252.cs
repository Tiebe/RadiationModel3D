using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium252 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium252";
        public override double halfLife { get; } = 83531183.05475d;
        public override double atomicWeight { get; } = 252.08163d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.96898d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Curium248() }, { 1.0d, new AlphaParticle(7238902.09) }, { 0.00014841d, new GammaParticle(43399.0, 0.02857) }, { 0.0001261d, new GammaParticle(100200.0, 0.01237) }, { 5.2380000000000005e-06d, new GammaParticle(155100.0, 0.00799) }, { 2.91e-07d, new GammaParticle(207400.0, 0.00598) }, { 0.0587228950413778d, new GammaParticle(18579.0, 0.06673) }, { 2.7567006732622607e-07d, new GammaParticle(104606.0, 0.01185) }, { 4.3161119042778463e-07d, new GammaParticle(109286.0, 0.01134) }, { 1.616493407144891e-07d, new GammaParticle(123280.0, 0.01006) }, { 2.185499086459893e-07d, new GammaParticle(124855.0, 0.00993) }, { 5.6900567931500163e-08d, new GammaParticle(126917.0, 0.00977) } } },
            { 0.03102d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
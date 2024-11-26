using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury192 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury192";
        public override double halfLife { get; } = 17460.0d;
        public override double atomicWeight { get; } = 191.96563d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold192() }, { 0.0126d, new GammaParticle(31610.0, 0.03922) }, { 0.001008d, new GammaParticle(95000.0, 0.01305) }, { 0.006768d, new GammaParticle(99400.0, 0.01247) }, { 0.01224d, new GammaParticle(101900.0, 0.01217) }, { 0.0072d, new GammaParticle(104500.0, 0.01186) }, { 0.0017280000000000002d, new GammaParticle(105400.0, 0.01176) }, { 0.00612d, new GammaParticle(109400.0, 0.01133) }, { 0.007632d, new GammaParticle(114500.0, 0.01083) }, { 0.0028799999999999997d, new GammaParticle(116500.0, 0.01064) }, { 0.00792d, new GammaParticle(120100.0, 0.01032) }, { 0.008928d, new GammaParticle(135900.0, 0.00912) }, { 0.01008d, new GammaParticle(139000.0, 0.00892) }, { 0.006840000000000001d, new GammaParticle(142500.0, 0.0087) }, { 0.01008d, new GammaParticle(146000.0, 0.00849) }, { 0.07200000000000001d, new GammaParticle(157200.0, 0.00789) }, { 0.03384d, new GammaParticle(186400.0, 0.00665) }, { 0.008496d, new GammaParticle(204600.0, 0.00606) }, { 0.01728d, new GammaParticle(245400.0, 0.00505) }, { 0.006840000000000001d, new GammaParticle(262600.0, 0.00472) }, { 0.5184000000000001d, new GammaParticle(274800.0, 0.00451) }, { 0.00432d, new GammaParticle(279200.0, 0.00444) }, { 0.0017280000000000002d, new GammaParticle(303100.0, 0.00409) }, { 0.055439999999999996d, new GammaParticle(306500.0, 0.00405) }, { 0.006840000000000001d, new GammaParticle(436700.0, 0.00284) }, { 0.599368293804d, new GammaParticle(11419.0, 0.10858) }, { 0.37500169378597425d, new GammaParticle(66991.0, 0.01851) }, { 0.6384094208137118d, new GammaParticle(68806.0, 0.01802) }, { 0.2154186543059069d, new GammaParticle(78048.0, 0.01589) }, { 0.277674645400314d, new GammaParticle(78983.0, 0.0157) }, { 0.0622559910944071d, new GammaParticle(80133.0, 0.01547) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
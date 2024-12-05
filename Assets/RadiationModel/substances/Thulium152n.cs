using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thulium152n : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium152n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 151.94711d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thulium152()), new(0.26039999999999996d, new GammaParticle(103500.0, 0.01198)), new(0.0588d, new GammaParticle(106500.0, 0.01164)), new(0.0924d, new GammaParticle(114400.0, 0.01084)), new(0.6048d, new GammaParticle(151500.0, 0.00818)), new(0.1092d, new GammaParticle(179500.0, 0.00691)), new(0.588d, new GammaParticle(235700.0, 0.00526)), new(0.84d, new GammaParticle(320100.0, 0.00387)), new(0.1512d, new GammaParticle(337400.0, 0.00367)), new(0.37799999999999995d, new GammaParticle(361400.0, 0.00343)), new(0.14279999999999998d, new GammaParticle(529600.0, 0.00234)), new(0.28559999999999997d, new GammaParticle(542600.0, 0.00229)), new(0.0672d, new GammaParticle(656900.0, 0.00189)), new(0.2688d, new GammaParticle(681300.0, 0.00182)), new(0.5628d, new GammaParticle(726200.0, 0.00171)), new(0.0252d, new GammaParticle(764900.0, 0.00162)), new(0.28559999999999997d, new GammaParticle(1018200.0, 0.00122)), new(0.0756d, new GammaParticle(1169600.0, 0.00106)), new(0.294d, new GammaParticle(1449800.0, 0.00086)), new(0.22059454067931d, new GammaParticle(8215.0, 0.15092)), new(0.16907190629873425d, new GammaParticle(49773.0, 0.02491)), new(0.2985026594257314d, new GammaParticle(50742.0, 0.02443)), new(0.09759691332185275d, new GammaParticle(57612.0, 0.02152)), new(0.12297211078553447d, new GammaParticle(58257.0, 0.02128)), new(0.025375197463681713d, new GammaParticle(59034.0, 0.021)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
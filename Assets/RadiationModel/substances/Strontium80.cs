using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Strontium80 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium80";
        public override double halfLife { get; } = 6378.0d;
        public override double atomicWeight { get; } = 79.92452d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Krypton80()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.1014d, new GammaParticle(175000.0, 0.00708)), new(0.04173d, new GammaParticle(235900.0, 0.00526)), new(0.01053d, new GammaParticle(316000.0, 0.00392)), new(0.04173d, new GammaParticle(378800.0, 0.00327)), new(0.03237d, new GammaParticle(414100.0, 0.00299)), new(0.06863999999999999d, new GammaParticle(553400.0, 0.00224)), new(0.39d, new GammaParticle(589000.0, 0.0021)), new(0.2d, new GammaParticle(511000.0, 0.00243)), new(0.023168900775d, new GammaParticle(1767.0, 0.70166)), new(0.15379548162207107d, new GammaParticle(13336.0, 0.09297)), new(0.2960452004274708d, new GammaParticle(13396.0, 0.09255)), new(0.07207124905955026d, new GammaParticle(15021.0, 0.08254)), new(0.0804315139504581d, new GammaParticle(15070.0, 0.08227)), new(0.008360264890907831d, new GammaParticle(15187.0, 0.08164)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
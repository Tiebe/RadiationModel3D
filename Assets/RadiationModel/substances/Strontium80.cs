using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium80 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium80";
        public override double halfLife { get; } = 6378.0d;
        public override double atomicWeight { get; } = 79.92452d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Krypton80() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) }, { 0.1014d, new GammaParticle(175000.0, 0.00708) }, { 0.04173d, new GammaParticle(235900.0, 0.00526) }, { 0.01053d, new GammaParticle(316000.0, 0.00392) }, { 0.04173d, new GammaParticle(378800.0, 0.00327) }, { 0.03237d, new GammaParticle(414100.0, 0.00299) }, { 0.06863999999999999d, new GammaParticle(553400.0, 0.00224) }, { 0.39d, new GammaParticle(589000.0, 0.0021) }, { 0.2d, new GammaParticle(511000.0, 0.00243) }, { 0.023168900775d, new GammaParticle(1767.0, 0.70166) }, { 0.15379548162207107d, new GammaParticle(13336.0, 0.09297) }, { 0.2960452004274708d, new GammaParticle(13396.0, 0.09255) }, { 0.07207124905955026d, new GammaParticle(15021.0, 0.08254) }, { 0.0804315139504581d, new GammaParticle(15070.0, 0.08227) }, { 0.008360264890907831d, new GammaParticle(15187.0, 0.08164) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
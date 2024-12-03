using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhenium186m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium186m";
        public override double halfLife { get; } = 6311385194918.4d;
        public override double atomicWeight { get; } = 185.95515d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhenium186()), new(0.0511768d, new GammaParticle(40350.0, 0.03073)), new(2.08e-07d, new GammaParticle(48840.0, 0.02539)), new(0.18110099999999998d, new GammaParticle(59009.0, 0.02101)), new(0.0109021d, new GammaParticle(99362.0, 0.01248)), new(0.539847552738528d, new GammaParticle(10063.0, 0.12321)), new(0.002548405904168926d, new GammaParticle(59718.0, 0.02076)), new(0.0044090067546175195d, new GammaParticle(61141.0, 0.02028)), new(0.0014655787041609664d, new GammaParticle(69395.0, 0.01787)), new(0.001871544005213554d, new GammaParticle(70206.0, 0.01766)), new(0.00040596530105258775d, new GammaParticle(71195.0, 0.01741)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
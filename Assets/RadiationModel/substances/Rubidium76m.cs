using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rubidium76m : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium76m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 75.93541d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rubidium76()), new(0.79d, new GammaParticle(70550.0, 0.01757)), new(0.75d, new GammaParticle(101300.0, 0.01224)), new(0.82d, new GammaParticle(145110.0, 0.00854)), new(0.14d, new GammaParticle(246320.0, 0.00503)), new(0.009428188245d, new GammaParticle(1767.0, 0.70166)), new(0.06287725495601632d, new GammaParticle(13336.0, 0.09297)), new(0.12103417700869358d, new GammaParticle(13396.0, 0.09255)), new(0.029465379959937386d, new GammaParticle(15021.0, 0.08254)), new(0.03288336403529013d, new GammaParticle(15070.0, 0.08227)), new(0.0034179840753527373d, new GammaParticle(15187.0, 0.08164)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nobelium253 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium253";
        public override double halfLife { get; } = 97.2d;
        public override double atomicWeight { get; } = 253.09056d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.55d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Fermium249()), new(1.0d, new AlphaParticle(9437002.09)), new(0.0038d, new GammaParticle(58300.0, 0.02127)), new(0.0038d, new GammaParticle(75000.0, 0.01653)), new(0.0029d, new GammaParticle(129200.0, 0.0096)), new(0.053d, new GammaParticle(150600.0, 0.00823)), new(0.0032d, new GammaParticle(209300.0, 0.00592)), new(0.295d, new GammaParticle(221700.0, 0.00559)), new(0.13d, new GammaParticle(279700.0, 0.00443)), new(0.0013d, new GammaParticle(669500.0, 0.00185)), new(0.118896521765238d, new GammaParticle(20618.0, 0.06013)), new(0.01413619080909472d, new GammaParticle(115320.0, 0.01075)), new(0.02162158276092799d, new GammaParticle(121090.0, 0.01024)), new(0.008439886261748008d, new GammaParticle(136318.0, 0.0091)), new(0.011478245315977291d, new GammaParticle(138067.0, 0.00898)), new(0.0030383590542292825d, new GammaParticle(140406.0, 0.00883)) } },
            { 0.45d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Fermium253()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
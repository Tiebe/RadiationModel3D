using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Technetium112 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium112";
        public override double halfLife { get; } = 0.271d;
        public override double atomicWeight { get; } = 111.92994d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ruthenium112()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.047939999999999997d, new GammaParticle(152700.0, 0.00812)), new(0.06392d, new GammaParticle(224000.0, 0.00554)), new(0.799d, new GammaParticle(236800.0, 0.00524)), new(0.26367d, new GammaParticle(287000.0, 0.00432)), new(0.07191d, new GammaParticle(381700.0, 0.00325)), new(0.11985d, new GammaParticle(408200.0, 0.00304)), new(0.16779d, new GammaParticle(510800.0, 0.00243)), new(0.19175999999999999d, new GammaParticle(523400.0, 0.00237)), new(0.0013d, new GammaParticle(2737.0, 0.45299)), new(0.006d, new GammaParticle(19150.0, 0.06474)), new(0.011000000000000001d, new GammaParticle(19279.0, 0.06431)), new(0.003d, new GammaParticle(21736.0, 0.05704)), new(0.004d, new GammaParticle(21875.0, 0.05668)), new(0.0005d, new GammaParticle(22072.0, 0.05617)) } },
            { 0.015d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ruthenium112()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.047939999999999997d, new GammaParticle(152700.0, 0.00812)), new(0.06392d, new GammaParticle(224000.0, 0.00554)), new(0.799d, new GammaParticle(236800.0, 0.00524)), new(0.26367d, new GammaParticle(287000.0, 0.00432)), new(0.07191d, new GammaParticle(381700.0, 0.00325)), new(0.11985d, new GammaParticle(408200.0, 0.00304)), new(0.16779d, new GammaParticle(510800.0, 0.00243)), new(0.19175999999999999d, new GammaParticle(523400.0, 0.00237)), new(0.0013d, new GammaParticle(2737.0, 0.45299)), new(0.006d, new GammaParticle(19150.0, 0.06474)), new(0.011000000000000001d, new GammaParticle(19279.0, 0.06431)), new(0.003d, new GammaParticle(21736.0, 0.05704)), new(0.004d, new GammaParticle(21875.0, 0.05668)), new(0.0005d, new GammaParticle(22072.0, 0.05617)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
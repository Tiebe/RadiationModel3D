using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iridium173m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium173m";
        public override double halfLife { get; } = 2.2d;
        public override double atomicWeight { get; } = 172.96775d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.88d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhenium173()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.12d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhenium169()), new(1.0d, new AlphaParticle(6964002.09)), new(0.039d, new GammaParticle(136200.0, 0.0091)), new(0.01709171295d, new GammaParticle(10063.0, 0.12321)), new(0.014298116687191196d, new GammaParticle(59718.0, 0.02076)), new(0.024737226102406914d, new GammaParticle(61141.0, 0.02028)), new(0.008222793430228578d, new GammaParticle(69395.0, 0.01787)), new(0.010500507210401893d, new GammaParticle(70206.0, 0.01766)), new(0.002277713780173316d, new GammaParticle(71195.0, 0.01741)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
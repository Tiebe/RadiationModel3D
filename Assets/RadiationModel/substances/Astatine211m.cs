using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Astatine211m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine211m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 210.99266d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Astatine211()), new(0.000105d, new GammaParticle(24200.0, 0.05123)), new(0.07d, new GammaParticle(96000.0, 0.01292)), new(0.4d, new GammaParticle(203700.0, 0.00609)), new(0.82d, new GammaParticle(253500.0, 0.00489)), new(0.89d, new GammaParticle(435100.0, 0.00285)), new(1.05d, new GammaParticle(511200.0, 0.00243)), new(0.79d, new GammaParticle(689400.0, 0.0018)), new(0.23d, new GammaParticle(713600.0, 0.00174)), new(1.09d, new GammaParticle(1067100.0, 0.00116)), new(0.97d, new GammaParticle(1536000.0, 0.00081)), new(0.7589381695999999d, new GammaParticle(13686.0, 0.09059)), new(0.18622771339894176d, new GammaParticle(78947.0, 0.0157)), new(0.3086817725823666d, new GammaParticle(81517.0, 0.01521)), new(0.10688539469102022d, new GammaParticle(92333.0, 0.01343)), new(0.14055429401869157d, new GammaParticle(93473.0, 0.01326)), new(0.03366889932767137d, new GammaParticle(94897.0, 0.01307)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Astatine216 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine216";
        public override double halfLife { get; } = 0.0003d;
        public override double atomicWeight { get; } = 216.00242d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth212()), new(1.0d, new AlphaParticle(8971902.09)), new(3e-05d, new GammaParticle(37600.0, 0.03297)), new(0.0002d, new GammaParticle(97900.0, 0.01266)), new(0.00023d, new GammaParticle(103400.0, 0.01199)), new(0.0027d, new GammaParticle(115200.0, 0.01076)), new(0.0001d, new GammaParticle(204800.0, 0.00605)), new(0.00025d, new GammaParticle(300000.0, 0.00413)), new(0.00033d, new GammaParticle(379300.0, 0.00327)), new(0.0013d, new GammaParticle(417900.0, 0.00297)), new(0.0071763903445d, new GammaParticle(12904.0, 0.09608)), new(0.004751757904624617d, new GammaParticle(74815.0, 0.01657)), new(0.007950071782875384d, new GammaParticle(77108.0, 0.01608)), new(0.0027232100401990813d, new GammaParticle(87388.0, 0.01419)), new(0.0035565123125d, new GammaParticle(88458.0, 0.01402)), new(0.0008333022723009189d, new GammaParticle(89784.0, 0.01381)) } },
            { 6e-05d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radon216()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 3e-09d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium216()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
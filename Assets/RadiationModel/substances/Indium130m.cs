using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium130m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium130m";
        public override double halfLife { get; } = 0.54d;
        public override double atomicWeight { get; } = 129.92502d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin130()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.04032d, new GammaParticle(96540.0, 0.01284)), new(0.10836d, new GammaParticle(391390.0, 0.00317)), new(0.03528d, new GammaParticle(411140.0, 0.00302)), new(0.02268d, new GammaParticle(492920.0, 0.00252)), new(0.02856d, new GammaParticle(1771090.0, 0.0007)), new(0.01848d, new GammaParticle(1775490.0, 0.0007)), new(0.84d, new GammaParticle(2258790.0, 0.00055)), new(0.03948d, new GammaParticle(2320720.0, 0.00053)), new(0.01932d, new GammaParticle(2388500.0, 0.00052)), new(0.0252d, new GammaParticle(2759000.0, 0.00045)), new(0.005136703487999999d, new GammaParticle(3753.0, 0.33036)), new(0.013849960470781148d, new GammaParticle(25044.0, 0.04951)), new(0.025921692814488397d, new GammaParticle(25271.0, 0.04906)), new(0.007329679795096459d, new GammaParticle(28579.0, 0.04338)), new(0.008773626714730462d, new GammaParticle(28810.0, 0.04304)), new(0.0014439469196340024d, new GammaParticle(29107.0, 0.0426)) } },
            { 0.0165d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin130()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.04032d, new GammaParticle(96540.0, 0.01284)), new(0.10836d, new GammaParticle(391390.0, 0.00317)), new(0.03528d, new GammaParticle(411140.0, 0.00302)), new(0.02268d, new GammaParticle(492920.0, 0.00252)), new(0.02856d, new GammaParticle(1771090.0, 0.0007)), new(0.01848d, new GammaParticle(1775490.0, 0.0007)), new(0.84d, new GammaParticle(2258790.0, 0.00055)), new(0.03948d, new GammaParticle(2320720.0, 0.00053)), new(0.01932d, new GammaParticle(2388500.0, 0.00052)), new(0.0252d, new GammaParticle(2759000.0, 0.00045)), new(0.005136703487999999d, new GammaParticle(3753.0, 0.33036)), new(0.013849960470781148d, new GammaParticle(25044.0, 0.04951)), new(0.025921692814488397d, new GammaParticle(25271.0, 0.04906)), new(0.007329679795096459d, new GammaParticle(28579.0, 0.04338)), new(0.008773626714730462d, new GammaParticle(28810.0, 0.04304)), new(0.0014439469196340024d, new GammaParticle(29107.0, 0.0426)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
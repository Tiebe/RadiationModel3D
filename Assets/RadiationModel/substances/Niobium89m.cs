using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Niobium89m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium89m";
        public override double halfLife { get; } = 3960.0d;
        public override double atomicWeight { get; } = 88.91344d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Yttrium89()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.812345d, new GammaParticle(507400.0, 0.00244)), new(0.9556999999999999d, new GammaParticle(588000.0, 0.00211)), new(0.0076456d, new GammaParticle(650300.0, 0.00191)), new(0.062120499999999995d, new GammaParticle(769600.0, 0.00161)), new(0.0152912d, new GammaParticle(1277500.0, 0.00097)), new(1.62d, new GammaParticle(511000.0, 0.00243)), new(0.007531376641078d, new GammaParticle(2161.0, 0.57374)), new(0.04240580121721197d, new GammaParticle(15691.0, 0.07902)), new(0.08115942816691288d, new GammaParticle(15775.0, 0.0786)), new(0.020680463347185995d, new GammaParticle(17736.0, 0.06991)), new(0.023699810995875148d, new GammaParticle(17824.0, 0.06956)), new(0.0030193476486891553d, new GammaParticle(17968.0, 0.069)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
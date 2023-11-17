def cashieralgorithm(montant, monnaie):
    monnaie.sort()
    monnaie.reverse()
    while montant != 0:
        for piece in monnaie:
            if montant >= piece:
                print(f"{montant//piece}x{piece}$")
                montant %= piece


cashieralgorithm(237, [5, 1, 10])
